projects=($(ls -1 -- **/*.csproj))
for i in "${projects[@]}"
do
    filename=$(basename -- "$i")    
    echo $filename
    filename="${filename%.*}"
    echo $filename
    buildPath="build/$filename-t"    
    echo $buildPath
	dotnet publish --configuration Release $i --output $buildPath
    mv $buildPath/wwwroot/ "build/$filename"        
    rm -rf $buildPath

    sed -i -e "s/<base href=\"\/\" \/>/<base href=\"\/Squibi\/$filename\/\" \/>/g" build/$filename/index.html
done
cp readme.md build/readme.md