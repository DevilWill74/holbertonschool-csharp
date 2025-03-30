#!/usr/bin/env bash
#simplifying projects preparation by Titania792 c:
let "num = 0"
for project in "$@"
do
    dotnet new console -o $project
    dotnet build $project
    mv $project/Program.cs $project/$project.cs
    touch $project/$num-main.cs
    let "num+=1"
done