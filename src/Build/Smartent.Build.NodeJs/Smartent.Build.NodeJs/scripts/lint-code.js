const path = require('path');
const { ESLint } = require('eslint');

const { formatter } = require('./eslint-msbuild-formatter');
const { handleErrorMessage } = require('./handle-error');

function getSourceType(filePath) {
    const parts = filePath.split('.');
    const extension = parts[parts.length - 1].toLowerCase();

    switch (extension?.toLowerCase()) {
        case 'mjs': return 'module';
        case 'cjs': return 'commonjs';
        default: return undefined;
    }
}

async function lintCode(code, id, firstRow = 1, overrideConfig = {}, formatterBeforeHandle = null) {
    if (!code?.trim()) handleErrorMessage('lintCode: Missing "code" parameter.');
    if (!id?.trim()) handleErrorMessage('lintCode: Missing "id" parameter.');
    const filePath = path.resolve(id.split('?')[0]);

    const options = {
        cwd: path.dirname(filePath),
        overrideConfig: { ...overrideConfig },
    };

    const sourceType = getSourceType(filePath);
    if (sourceType) {
        if (!options.overrideConfig.parserOptions) options.overrideConfig.parserOptions = {};
        if (!options.overrideConfig.parserOptions.sourceType) {
            options.overrideConfig.parserOptions.sourceType = sourceType;
        }
    }

    const eslint = new ESLint(options);
    const results = await eslint.lintText(code, { filePath });

    if (!Array.isArray(results) || results.length === 0) return;

    for (let i = 0; i < results.length; i++) {
        const result = results[i];

        for (let j = 0; j < result.messages.length; j++) {
            const message = result.messages[j];
            message.line += firstRow - 1;
        }
    }

    formatter(results, formatterBeforeHandle);
}

module.exports = { lintCode };