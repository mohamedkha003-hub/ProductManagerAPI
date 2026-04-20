# 📦 نظام إدارة المنتجات (Product Manager API)

مشروع بسيط لإدارة المنتجات (إضافة، عرض، حذف) تم بناؤه باستخدام **ASP.NET Core 9** و **Entity Framework**.

## المميزات
- **Backend:** بناؤه باستخدام RESTful API.
- **Frontend:** واجهة بسيطة بـ HTML/JS مع حساب تلقائي لإجمالي الأسعار.
- **Database:** الربط مع SQL Server باستخدام Code First Migration.
- **Validation:** تحقق من البيانات قبل الإضافة.

##  التكنولوجيات المستخدمة
- .NET 9
- Entity Framework Core
- SQL Server
- Swagger UI (للتوثيق وتجربة الـ API)
- HTML/CSS/JavaScript

# كيف تشغل المشروع عندك؟

1. **تحميل المشروع:** قم بتحميل الملفات وتأكد من وجود .NET 9 SDK على جهازك.
2. **قاعدة البيانات:** - افتح ملف `appsettings.json`.
   - قم بتعديل الـ `ConnectionString` ليتناسب مع السيرفر الخاص بك.
3. **تجهيز الداتابيز:** افتح الـ Terminal واكتب:
   ```bash
   dotnet ef database update
