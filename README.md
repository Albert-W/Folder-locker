# Folder-locker

This is a tiny software used to lock folder, **without compression and encryption**, super convenient and fast。

[中文介绍](README.CN.md)

## Usage Demonstration

![](locker.gif)

On the folder you want to lock, right-click to call out the lock panel, and enter the password twice to confirm the lock.

On the locked folder, right-click, enter the password to cancel the lock.

## Project Introduction

The project is divided into two directories：

- DButility 
    - Used to save passwords through the lightweight database SQLite.
    - The password is encrypted by Md5 algorithm, and SQL injection is prevented by SQL parameters.
- folderLocker 
    - Used to implement business logic.
    

## Note before using it：
- The password is saved in the local database and is not uploaded to any server.
- Removing the software also deletes the database and therefore the password.

## How to use

- Download the software package [Folder Locker.exe](https://github.com/Albert-W/Folder-locker/releases)
- For installation, it is recommended to install it on the D drive.
- You can use it by right-clicking, or by clicking the icon and open the software interface.


If you forget your password：

If the password is lost and the file is locked, it can be renamed via the command line tool.

For example, if your folder is E:\folder, open the cmd command window and execute the following command
```
ren e:\folder.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0} new_folder
```

Where {2559a1f2-21d7-11d4-bdaf-00c04f60b9f0} remains unchanged, and "new_folder" is replaced with the file name you want.


