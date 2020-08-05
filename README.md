# IronPDF UWP demo

---

This code will build and run fine in "Debug" mode. Click the button to generate and save a PDF into the downloads folder. 

However, when building in "Release" mode, I get the following error:

```
Error		ILT0014: Failed to compile interop source code. See the build log for error details.
```

I belive the issue is due to the restrictions of .NET Native.