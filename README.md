# NodeMoonOS
NodeMoonOS - Operating system based on CosmosOS.
# Overview
![image](https://user-images.githubusercontent.com/47820634/154625658-31d2f7e0-6caa-4a75-b194-1fdde6640f78.png)
# Welcome to NodeMoonOS!
What thing NodeMoonOS can doing?
* Access your disk
* Cool Terminal
* Sound
* Hardware info
* Open Source and more?
# Help Guide
**BASIC**
* echo -- displaying lines of text by echo (your message)
* beep -- playing beep sound
* playbeep -- playbeep sound
<pre>
</pre>
**Operating System - Hardware Info**
* sysinfo -- show nodemoon icon, cpu info, ram
* kernelinfo -- show name, version, based of nodekernel.
* hardwareinfo -- show hardware info are possible we can do.
<pre>
</pre>
**System tools**
* date -- show date and time
* powercontrol -- reboot or shutdown device eg. powercontrol reboot, powercontrol shutdown
<pre>
</pre>
**Disk manager**
* diskmg -- check disk info eg.
```
diskmg -s 0: -- check disk space for drive 0:
diskmg -t 0: -- check filesystem for drive 0:
```
**Disk tools**
* cat -- read text file by eg.
```
cat 0:\sus.txt
OUTPUT:
im amogus and will kill your.
```
* cd -- cd directory path eg
```cd baka```
* ls -- list of file & dir eg.
```
// Check list of file from other path.
ls 0:\baka
// check list of file on default path (use cd)
ls
```
* mkdir -- create folder eg.
```
mkdir bakafolder
// DONT USE mkdir 0:\aaaaaa please cd or switchpath FIRST!
```
* remove -- remove file eg.
```
remove sussybaka
or
remove -f 0:\sussybaka
// NOTICE: DELETE FOLDER ARE IN COMING SOON
```
* touch -- create file eg.
```
touch grass
```
* write -- be like echo hi > sus.txt in unix eg.
```
// PLEASE CHECK FILE YOU WILL OVERWRITE IS HAVE OR NO?
write sus.txt
*press enter
context > im sus
*press enter
cat sus.txt
OUTPUT:
im sus
```

# Q&A
* Q: I can use this source code?
* A: You can! but DONT COPY ALL.
* Q: i can cd .. ?
* A: NO IN NOW but you can use resetpath (reset defaultpath to 0:\) or switchpath (eg. switchpath 0:\folder)
* Q: I can access **other** drive not 0:\ by cd?
* A: Use switchpath (eg. switchpath 1:\)
* Q: i can use internet access?
* A: not done.
* Q: I can format disk?
* A: you cannot in now.
* Q: why i can't access harddrive? eg. failed diskrun status or ls error?
* A: Make sure your disk type are:
```
FAT12
FAT16
FAT32
ExFAT
```
* Q: i can ask Q&A or issues.
* A: [Click here](https://github.com/fusedevgithub/NodeMoonOS/issues)
