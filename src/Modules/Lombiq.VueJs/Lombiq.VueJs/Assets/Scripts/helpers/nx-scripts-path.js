const fs = require('fs');
const path = require('path');

/**
 * Resolves node_modules/.nx/scripts whether the helpers run from the module project directory or from a copied
 * lombiq-vuejs package under a consumer's node_modules (e.g. Lombiq.VueJs.Samples).
 */
function getNxScriptsPath() {
    let dir = __dirname;
    for (;;) {
        const scriptsDir = path.join(dir, 'node_modules', '.nx', 'scripts');
        if (fs.existsSync(path.join(scriptsDir, 'handle-error.js'))) return scriptsDir;

        const parent = path.dirname(dir);
        if (parent === dir) break;
        dir = parent;
    }

    throw new Error('Unable to locate node_modules/.nx/scripts (handle-error.js).');
}

module.exports = getNxScriptsPath;