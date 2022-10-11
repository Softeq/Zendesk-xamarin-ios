#!/bin/bash

for framework in *.framework; do
	frameworkName=$(echo ${framework} | cut -d '.' -f 1)
	targetFramework=../${frameworkName}.Bindings/${framework}
	rm -rf ${targetFramework}
	cp -r ${framework} ${targetFramework}
done
