# TcMatrix

## Description

A TwinCAT 3 library for manipulating 2D data sets of LREAL.

Features include:

* Element-wise setting, getting, summing, scaling, and power functions
* Initialization as copies, zeros, trapezoidal, and other pre-defined matrix types
* Matrix operations like multiplication, transposition, and inversion
* Vector operations for 1D matricies like dot/cross product and normalization
* Complex access operations similar to ['slicing'](https://en.wikipedia.org/wiki/Array_slicing)
* Options to use static or dynamically allocated memory
* Reading/Writing with CSV files, output to the ADS message logger

Compare to:

* [CODESYS Matrix Library](https://us.store.codesys.com/matrix-library.html) ([docs](https://store.codesys.com/media/n98_media_assets/files/2111000003-D/4/Matrix%20Bibliothek_en.pdf))
* [Siemens Library of General Functions](https://support.industry.siemens.com/cs/document/109479728/library-of-general-functions-(lgf)-for-simatic-step-7-(tia-portal)-and-simatic-s7-1200-s7-1500) ([docs](https://cache.industry.siemens.com/dl/files/728/109479728/att_1019474/v3/109479728_LGF_TIAV16_DOC_V5_0_0_en.pdf))

## Contents

* [Installation](#twincat-3-installation)
* [Full API reference](/api/PlcDocu.TcMatrix.Matrix.html)
* [Examples](#examples)
   * [Projects](#projects-with-implementations)

## TwinCAT 3 Installation

### From Binary

1. Go to the [releases page](https://github.com/BurksEngineering/TcMatrix/releases) and download the *.library file from the latest release, saving it to a temporary directory somewhere on the computer running TwinCAT.
1. Follow the [library installation instructions](https://infosys.beckhoff.com/english.php?content=../content/1033/tc3_plc_intro/4189333259.html) from Beckhoff, using the 'Install' option and browsing for the local copy you had just downloaded.
1. After installtion, you may delete the local copy of the library that you had downloaded. Beckhoff has likely copied it to a version-specific folder in `C:\TwinCAT\3.1\Components\Plc\Managed Libraries\Burks Engineering\TcMatrix\`

### From Source

Preconditions:

* TwinCAT 3.1.4024 XAE
* TwinCAT 3.1.4024 XAR, ideally configured with an isolated core
* Visual Studio Community or Shell, 2019 or higher
* [TcUnit](https://github.com/tcunit/TcUnit) v1.2 or higher

Compilation:

1. Clone the repository to a computer running TwinCAT 3
1. Open the [main solution file](TcMatrix.sln) in Visual Studio
1. Within the Visual Studio *TcMatrix* project, right click on the *TcMatrix/TcMatrix Project* item and select *Rebuild*
   1. There should be no compile errors, although there may be warnings
1. Right click on the *TcMatrix/TcMatrix Project* item again and select *Save as library and install*
   1. The file can be saved anywhere, but a local *Builds* folder is always a good choice

Test:

1. Within the Visual Studio *TcMatrixTest* project, right click on the *PLC/TcMatrixTest/TcMatrixTest Project* item and select *Rebuild*
   1. There should be no compile errors, although there may be warnings
1. Open the *SYSTEM/Real-Time* item and click *Read From Target*, then assign all tasks to an isolated core from your system
1. In the Visual Studio toolbar (or TwinCAT file menu) click *Activate Configuration*
1. When prompted, agree to start the project in run mode and auto-start the boot project
1. After a few seconds the TcUnit results should be visible in the Error List window. Verify that all tests have passed.



## Examples

### Projects With Implementations

* [TcTransform](https://github.com/BurksEngineering/TcTransform):  Static memory 3x1, 3x3, and 4x4 matricies for common 3D coordinate system transformations
* The unit tests within this project provide a large number of simple examples and usages
* The ExternalStaticMatrix is one example of how to implement the StaticMatrix base class