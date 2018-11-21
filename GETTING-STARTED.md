# Getting Started 

## Test environment

Samples are included for Windows 7 and above.
The SigCaptX samples need both the Signature and SigCaptX SDKs to be installed.
To test the samples use a Wacom device such as an STU-500 or a pen/tablet device such as a DTU-1141.
To use a pen/tablet device its driver will need to be installed separately to include the wintab interface used by the Signature SDK.
See the FAQs for device installation:
https://developer-docs.wacom.com/display/DevDocs/WILL+SDK+-+FAQs


## Download the SDK

Download the SDK from https://developer.wacom.com/developer-dashboard

* login using your Wacom ID
* Select **Downloads**
* Select **Signature Edition**
* Under WILL SDK for Signature: Download Signature SDK for Windows Desktop
* Accept the End User License Agreement to use the SDK

The downloaded Zip file contains the SDK with documentation.
The folders 'SignatureSDK' and 'SigCaptX' are included in the Zip file and contain the MSI and EXE installers.

## Download an evaluation license

A license is needed to use the Signature SDK and a fully functional evaluation license is free to download as follows:

* Navigate to https://developer.wacom.com/developer-dashboard
* login using your Wacom ID
* Select **Licenses**
* Select **New Evaluation License**
* Select **Generate Signature Edition License**
* Return to Licenses where the new license file is ready for download
* Download the signature-edition-evaluation-license.txt license file

The license is supplied as a JWT text string in a text file. This will need to be copied into your application. The self-service evaluation licenses have a three-month expiry date from the time of creation. However you can generate a new license at any time. 


## Install the SigCaptX SDK

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


SigCaptX is supplied as a 32-bit application and requires the 32-version of the Signature SDK, regardless of your Windows version.
To simplify the installation a combined installer is included:
**Wacom-SigCaptX-XX.exe**

Run the installer with default options to install the components in:
C:\Program Files (x86)\Common Files\WacomGSS

## HTML Samples

Samples equivalent to the Signature SDK samples are included with the changes needed to use SigCaptX components.
PortCheck.htm is included to check that the SigCaptX service is available, independently of signature capture.

Having downloaded the samples you will need to install your Signature license in the code:

Search and replace '<<license>>' with your evaluation license string.
The samples can then be opened and run in any of the commonly used browsers: Internet Explorer/Firefox/Chrome.


| Sample                        | Description                                                           |
| ----------------------------- | --------------------------------------------------------------------- |
| PortCheck.htm                 | Use this sample to check that the SigCaptX service is available |
| SigCaptX-Capture.html         | Demonstrates signature capture  |
| SigCaptX-Capture-Hash.html    | Demonstrates signature capture with data hash  |
| SigCaptX-Wizard.html          | Demonstrates use of the Wizard control. Uses a checkbox and captures a signature  |
| SigCaptX-WizardPINPad.html    | Demonstrates the Wizard control pin pad input |


----

        




