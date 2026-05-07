# Entity Framework tools 版本更新
dotnet tool update --global dotnet-ef
# SmartTask.AccessDatas專案 缺少 using Microsoft.EntityFrameworkCore; 指示詞
dotnet add SmartTask.AccessDatas package Microsoft.EntityFrameworkCore.SqlServer

# 產生新的 migration 以納入所有模型變更
dotnet ef migrations add UpdateModel --project SmartTask.AccessDatas

# 新增 migration InitialCreate
dotnet ef migrations add InitialCreate --project SmartTask.AccessDatas

# 根據 migration 自動建立 BackendDB 資料庫與資料表
dotnet ef database update --project SmartTask.AccessDatas