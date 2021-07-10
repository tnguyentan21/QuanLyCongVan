# Record-Management-Sysytem

Record Management System (RMS) an Windows application for managing records and documents for the University of Information Technology.


## Requirement

Use Windows OS.

Use Visual Studio.

Use Sql Server 2012.


## Permission

This application require permission to access `local storage` of the computer.


## Installation
Restore the database with the backup file `QLCV.bak` in `Backup` folder
Add your server name in SQL Server to `SQLConnection.cs` file by change the code below.

```
public static SqlConnection cnn = new SqlConnection("Data Source = LAPTOPNEWVN\\SQLSERVER12; Initial Catalog = QLCV; Integrated Security = True");
```
Open the project with Visual Studio then run the app.
## Usage
**To change/add accounts of the system, follow these steps:**
1. Open the `QLCV` database in SQL Server 2012

2. Open `NguoiDung` table to view all user info.

3. Change `MaNV` to change user code.

4. Change `TenNV` to change fullname of the user.

5. Change `IDPB` to change Department ID.

6. Change `IDCV` to change the role of the account. Fill `1` for manager role, `2` for employee role.

7. Change `Username` to change the username of the account.

8. Change `Password` to change the password of the account.

9. Save the changes in the database

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
This application is a product of a group consist of following members:
```
17521000 Nguyễn Tấn Tài
17520793 Lê Thanh Nghị
```

