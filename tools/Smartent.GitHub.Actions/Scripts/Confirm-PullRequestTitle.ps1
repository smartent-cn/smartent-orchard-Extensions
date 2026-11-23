param (
    [Parameter(Mandatory = $true, Position = 0)]
    [string] $Title
)

-not [string]::IsNullOrEmpty((Get-JiraIssueKeyFromPullRequestTitle $Title))
