# The RedMax File System

The RedMax File System is similar to that of the Windows C:\ Drive File System, except without as many files and folders, and a backwards system folder, meaning all 32-bit apps will be in "systemx86", instead of "SysWOW64", and all 64-bit programs will be in the folder "systemx64" instead of "system32".




# The User Profiling Service

The RedMax UPS uses an integer to assign the user profile. The integer represents the type of user. If the integer is **0**, RedMax will treat the user as a "SYSTEM User", meaning that it will log you in as a user with unrestricted access to files and folders. If the integer is **1**, RedMax will treat the user as a System Administrator, which is similar to the Windows XP User. If the integer is **2**, RedMax will treat this as a user with the Administrator Privellage. If the integer is **4**, RedMax will assign the user with the **Guest Profile**, and if the integer is **5**, RedMax will assign this the **Temporary Profile**, similar to if you were using a network connection that had all of the profiles, and that connection was down, and you tried to log on.
