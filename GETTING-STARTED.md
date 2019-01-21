# Getting Started 

## Test environment

Samples are included for Windows 7 and above.
The SigCaptX samples need both the Signature and SigCaptX libraries to be installed.
To test the samples use a Wacom device such as an STU-500 or a pen/tablet device such as a DTU-1141.
To use a pen/tablet device its driver will need to be installed separately to include the wintab interface used by the Signature Library.
See the FAQs for device installation:
https://developer-docs.wacom.com/display/DevDocs/WILL+SDK+-+FAQs


## Download the SDK

Download the SDK from https://developer.wacom.com/developer-dashboard

* login using your Wacom ID
* Select **Downloads for signature**
* Download **Signature SDK for Windows Desktop**
* Accept the End User License Agreement to use the SDK

The downloaded Zip file contains the SDK with documentation.
The folders 'SignatureSDK' and 'SigCaptX' are included in the Zip file and contain the MSI and EXE library installers.

## Download an evaluation license

A license is needed to use the Signature Library and a fully functional evaluation license is free to download as follows:

* Navigate to https://developer.wacom.com/developer-dashboard
* login using your Wacom ID
* Select **Licenses**
* Select **New Evaluation License**
* Select **Generate Evaluation License**  for WILL SDK for signature
* Return to Licenses where the new license file is ready for download
* Download the license file

The license is supplied as a JWT text string in a text file. This will need to be copied into your application. The self-service evaluation licenses have a three-month expiry date from the time of creation. However you can generate a new license at any time. 


## Install the SigCaptX Library

Make sure that any browsers using SigCaptX have already been installed and run so they can be located in the installation process.
In addition note:

* Firefox 64-bit
    * With .EXE (combined) installer: no action necessary
    * With .MSI installer: must be run from command line with 'FF64=1'

* Firefox Portable
    * With .EXE (combined) installer:  
        * From command line (eg for silent install), add FFP="Firefox Portable Folder"
        * From UI, click 'Options' then enter or browse to "Firefox Portable Folder"
    * With .MSI installer:  must be run from command line with FFP="Firefox Portable Folder"
    
* MSI log files are created in the folder %TEMP%


SigCaptX is supplied as a 32-bit application and requires the 32-version of the Signature Library, regardless of your Windows version.
To simplify the installation a combined installer is included:
**Wacom-SigCaptX-XX.exe**

Run the installer with default options to install the library in:
C:\Program Files (x86)\Common Files\WacomGSS

## HTML Samples

The samples demonstrate use of the SigCaptX library.

PortCheck.htm is included to check that the SigCaptX service is available, independently of signature capture.

Having downloaded the samples you will need to install your Signature license in the code:

Search and replace '<<license>>' with your evaluation license string.
For example change:
```
    const LICENCEKEY = "<<license>>";
```    
to:
```
    const LICENCEKEY = "AbAD.......wQ";
```    

The samples can then be opened and run in any of the commonly used browsers: Internet Explorer/Edge/Firefox/Chrome.


| Sample                        | Description                                                           |
| ----------------------------- | --------------------------------------------------------------------- |
| PortCheck.htm                 | Use this sample to check that the SigCaptX service is available |
| SigCaptX-Capture-html         | Signature capture showing use of base64 image, SigText and hash verification |
| SigCaptX-Wizard.html          | Wizard sample showing use of check boxes, radio buttons, images for buttons, SigText generation, font sizes and colour (for STUs which support colour) |
| SigCaptX-WizardPINPad.html    | Demonstrates full version of PIN pad input |
| demo.htm                      | Basic sample illustrating use of dynamic capture, wizard capture and single digit PIN input |


### Demo.htm

The sample webpage "demo.htm" is included in the samples. In order to test this first copy it to the demo folder in C:\Program Files (x86)\Wacom SigCaptX. 
To simplify the use of this sample the web server is a localhost python process and the server SSL certificate used is the same one as the one used by SigCaptX.
In a real world scenario the webpage server would be remote and it would need to use its own certificate.

To run the sample, first you need to install Python 2.x on your machine and add Python to the windows PATH environment variable. Also, if you have modified the "start_port" value in the registry, you will need to modify the webpage demo/demo.htm. 
The example also uses the wgssSigCaptX.js and base64.js files. The web server needs to know the port number beforehand so that it can talk to the local SigCaptX background service of the user's machine. 
Specifically, you need to change this line of demo/demo.htm:

```
var wgssSignatureSDK = new WacomGSS_SignatureSDK(onDetectRunning, 8000)
```

Change 8000 to the port that you have specified as "start_port" in the registry.

Then execute demo/server.py:

> python server.py

Now you can load the webpage from a browser by visiting https://localhost:7999/demo.htm

----

        




