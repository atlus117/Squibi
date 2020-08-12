filename=$(basename)
filename=${filename%.*}
buildPath="build/$filename-t"
dotnet publish --configuration Release $ --output $buildPath
mv $buildPath/wwwroot/ "build/$filename"
rm -rf $buildPath


sed -i -e "s/<base href=\"\/\" \/>/<base href=\"\/Squibi\/$filename\/\" \/>/g" build/$filename/index.html
cp readme.md build/readme.md