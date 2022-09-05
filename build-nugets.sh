#!/bin/bash

IFS=$'\n'
regex="- '(.*) -> (.*)'"
for line in $(cat azure-pipelines/nuget.yml); do
    if [[ ${line} =~ ${regex} ]]; then
        projectName=${BASH_REMATCH[1]}
        nugetName=${BASH_REMATCH[2]}
        projectPath=${projectName}/${projectName}.csproj
        msbuild ${projectPath} /p:Configuration=Release /t:Clean
        rc=$?; if [[ $rc != 0 ]]; then exit $rc; fi
        msbuild ${projectPath} /p:Configuration=Release /t:Restore
        rc=$?; if [[ $rc != 0 ]]; then exit $rc; fi
        msbuild ${projectPath} /p:Configuration=Release /t:Build
        rc=$?; if [[ $rc != 0 ]]; then exit $rc; fi
        nuget pack nuget/${nugetName}.nuspec
        rc=$?; if [[ $rc != 0 ]]; then exit $rc; fi
    fi
done
