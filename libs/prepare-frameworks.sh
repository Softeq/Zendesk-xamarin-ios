#!/bin/bash

rm -rf *.xcframework
rm -rf *.framework

for zipFile in *.zip; do
	unzip ${zipFile} > /dev/null
	frameworkName=$(echo ${zipFile} | cut -d '.' -f 1)
	xcframework="${frameworkName}.xcframework"
	framework="${frameworkName}.framework"
	cp -r ${xcframework}/ios-arm64_armv7/${framework} .
	cd ${framework}
    mv ${frameworkName} iphone
	lipo -remove arm64 ../${xcframework}/ios-arm64_i386_x86_64-simulator/${framework}/${frameworkName} -o simulator
	lipo -create -output ${frameworkName} iphone simulator
	rm iphone
	rm simulator
	echo "processed $(pwd)"
	cd ..
	rm -rf ${xcframework}
done
