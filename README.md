#Canopy F# on Mono

Instructions to get Canopy F# running on OSX. Because it's that good.

##Download and Install Mono

Download Mono from here, just the MRE, no need for Mono Develop: http://www.go-mono.com/mono-downloads/download.html

##Install Homebrew

Install Brew for OSX: http://brew.sh/

##Bulding F# from source on OSX (because we're cool like that)

Clone the F# GitHub repo: https://github.com/fsharp/fsharp.git

Then build it like a boss

    brew install automake
    ./autogen.sh --prefix=/Library/Frameworks/Mono.framework/Versions/Current/
    make
    sudo make install

The output will be copied to `./lib/release`. Copy the contents of `./lib/release` to `/usr/local/fsharp/bin/`.

Create two shell scripts in `/usr/local/fsharp/bin`

Name the first one `fsc` (no extention) with the following contents:

    #!/bin/bash
    mono /usr/local/fsharp/bin/fsc.exe $@

Name the next one `fsi` (no extention) with the following contents:

    #!/bin/bash
    mono /usr/local/fsharp/bin/fsi.exe $@

Then mark them as executables

    chmod +x /usr/local/fsharp/bin/fsc
    chmod +x /usr/local/fsharp/bin/fsi

Add the `/usr/local/fsharp/bin` directory to your path. I added the following line to my `~/.bashrc`

    ### I Added fsharp
    export PATH="/usr/local/fsharp/bin:$PATH"

Then reload `~/.bashrc`

    source ~/.bashrc

##Your first F# app

This repo comes with a hello world app. Run the following command:

  `fsi program.fsx`

And you should get the following output:

  `hello world`


