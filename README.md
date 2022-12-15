# 資料庫遷移練習
#### [移轉概觀](https://learn.microsoft.com/zh-tw/ef/core/managing-schemas/migrations/?tabs=vs)

## 安裝工具
```powershell
Install-Package Microsoft.EntityFrameworkCore.Tools
```
## 在 套件管理員主控台 中執行下列命令來更新工具。
```powershell
Update-Package Microsoft.EntityFrameworkCore.Tools
```
## 建立第一個移轉
```powershell
Add-Migration AddSchoolCreatedTimestamp
```
