using Microsoft.EntityFrameworkCore;
using WebSite.Models;

namespace WebSite.Data;

public static class DbInitializer
{
    public static async Task InitializeAsync(RealEstateDbContext db)
    {
        await db.Database.EnsureCreatedAsync();

        if (await db.staticDatas.AnyAsync())
        {
            return;
        }

        var homeGroup = new StaticDataGroup
        {
            Id = 1,
            Description = "Home page texts",
            Page = "Home",
            Container = "Home"
        };

        var statuses = new List<Status>
        {
            new() { Id = 1, Name = "Sale" },
            new() { Id = 2, Name = "Rent" },
            new() { Id = 3, Name = "Bathroom" },
            new() { Id = 4, Name = "Toilet" }
        };

        var staticDatas = new List<StaticData>
        {
            new() { Id = "E1", Name = "HeroTitle", GroupId = 1, StringContentEn = "Find the Right Property in Oman", StringContentFa = "پیدا کردن ملک مناسب در عمان", StringContentAr = "اعثر على العقار المناسب في عمان" },
            new() { Id = "E2", Name = "HeroDesc", GroupId = 1, StringContentEn = "Muscat Gates connects trusted real estate agencies with property seekers across Oman. Discover verified listings for sale and rent in Muscat and beyond.", StringContentFa = "موسکت گیتس آژانس‌های معتبر املاک را با متقاضیان ملک در سراسر عمان متصل می‌کند.", StringContentAr = "يربط Muscat Gates وكالات العقارات الموثوقة بالباحثين عن العقارات في جميع أنحاء عمان." },
            new() { Id = "E3", Name = "HeroButton", GroupId = 1, StringContentEn = "Browse Properties", StringContentFa = "مشاهده املاک", StringContentAr = "تصفح العقارات" },
            new() { Id = "A1", Name = "AboutLabel", GroupId = 1, StringContentEn = "About Us", StringContentFa = "درباره ما", StringContentAr = "من نحن" },
            new() { Id = "A2", Name = "AboutTitle", GroupId = 1, StringContentEn = "Your Trusted Real Estate Listing Platform in Oman", StringContentFa = "پلتفرم قابل اعتماد آگهی ملک در عمان", StringContentAr = "منصة موثوقة لإعلانات العقارات في عمان" },
            new() { Id = "A3", Name = "AboutDesc1", GroupId = 1, StringContentEn = "Muscat Gates is a modern real estate platform that connects property seekers with professional real estate agencies across Oman.", StringContentFa = "موسکت گیتس یک پلتفرم مدرن املاک است که جویندگان ملک را به آژانس‌های حرفه‌ای در عمان متصل می‌کند.", StringContentAr = "Muscat Gates هي منصة عقارية حديثة تربط الباحثين عن العقارات بالوكالات المهنية في عمان." },
            new() { Id = "A4", Name = "AboutDesc2", GroupId = 1, StringContentEn = "Our mission is to make property searching simple, transparent, and reliable.", StringContentFa = "ماموریت ما ساده، شفاف و قابل اعتماد کردن جستجوی ملک است.", StringContentAr = "مهمتنا هي جعل البحث عن العقار بسيطًا وشفافًا وموثوقًا." },
            new() { Id = "S1", Name = "ServiceTitle", GroupId = 1, StringContentEn = "Real Estate Solutions for Buyers, Tenants, and Agencies", StringContentFa = "راهکارهای املاک برای خریداران، مستأجران و آژانس‌ها", StringContentAr = "حلول عقارية للمشترين والمستأجرين والوكالات" },
            new() { Id = "S2", Name = "SaleService", GroupId = 1, StringContentEn = "Property Listings for Sale", StringContentFa = "فهرست املاک برای فروش", StringContentAr = "قوائم العقارات للبيع" },
            new() { Id = "S3", Name = "RentService", GroupId = 1, StringContentEn = "Rental Properties", StringContentFa = "املاک اجاره‌ای", StringContentAr = "العقارات للإيجار" },
            new() { Id = "ST1", Name = "StatsTitle", GroupId = 1, StringContentEn = "Growing Real Estate Network in Oman", StringContentFa = "شبکه رو به رشد املاک در عمان", StringContentAr = "شبكة العقارات المتنامية في عمان" },
            new() { Id = "T1", Name = "TestimonialsTitle", GroupId = 1, StringContentEn = "What Our Partners Say", StringContentFa = "همکاران ما چه می‌گویند", StringContentAr = "ما يقوله شركاؤنا" },
            new() { Id = "T2", Name = "TestimonialsDesc", GroupId = 1, StringContentEn = "Real estate professionals trust Muscat Gates to showcase their properties and connect with buyers and tenants.", StringContentFa = "حرفه‌ای‌های املاک به موسکت گیتس اعتماد می‌کنند.", StringContentAr = "يثق متخصصو العقارات في Muscat Gates لعرض عقاراتهم والتواصل مع المشترين والمستأجرين." },
            new() { Id = "F1", Name = "FooterAbout", GroupId = 1, StringContentEn = "Muscat Gates is a real estate listing platform that connects property seekers with trusted agencies in Oman.", StringContentFa = "موسکت گیتس پلتفرم آگهی املاک است که متقاضیان را به آژانس‌های قابل اعتماد در عمان متصل می‌کند.", StringContentAr = "Muscat Gates هي منصة إعلانات عقارية تربط الباحثين عن العقارات بالوكالات الموثوقة في عمان." },
            new() { Id = "C1", Name = "ContactTitle", GroupId = 1, StringContentEn = "Contact Information", StringContentFa = "اطلاعات تماس", StringContentAr = "معلومات الاتصال" }
        };

        var keywords = new List<Keyword>
        {
            new() { Id = 1, ContentEn = "Villa", ContentFa = "ویلا", ContentAr = "فيلا" },
            new() { Id = 2, ContentEn = "Apartment", ContentFa = "آپارتمان", ContentAr = "شقة" },
            new() { Id = 3, ContentEn = "Commercial", ContentFa = "تجاری", ContentAr = "تجاري" }
        };

        var materials = new List<Material>
        {
            new() { Id = 1, Name = "Marble", ContentEn = "Marble", ContentFa = "مرمر", ContentAr = "رخام" },
            new() { Id = 2, Name = "Wood", ContentEn = "Wood", ContentFa = "چوب", ContentAr = "خشب" }
        };

        var house = new House
        {
            Id = 1,
            PropertyCode = "MG-1001",
            City = "Muscat",
            District = "Al Khuwair",
            Neighborhood = "Royal Plaza",
            AddressLine = "Sultan Qaboos Street",
            LandArea = 520,
            BuildingArea = 310,
            UnitNumber = 12,
            YearRenovated = 2024,
            NearbyFacilities = "Mall, school, hospital",
            AmenitiesEn = "Pool, Parking, Elevator",
            AmenitiesFa = "استخر، پارکینگ، آسانسور",
            AmenitiesAr = "مسبح، موقف، مصعد",
            RegistrationTime = DateTime.UtcNow,
            ConstructionTime = new DateTime(2020, 1, 1),
            HasParking = true,
            ParkingCount = 2,
            Deed = "Freehold",
            ConstructionStatus = "Ready",
            HasPool = true,
            PoolArea = 40,
            TreeCount = 4,
            HasElevator = true,
            FloorCount = 3
        };

        var house2 = new House
        {
            Id = 2,
            PropertyCode = "MG-1002",
            City = "Muscat",
            District = "Al Mouj",
            Neighborhood = "Marina",
            AddressLine = "Coastal Road",
            LandArea = 400,
            BuildingArea = 240,
            RegistrationTime = DateTime.UtcNow,
            ConstructionTime = new DateTime(2021, 1, 1),
            HasParking = true,
            ParkingCount = 1,
            Deed = "Leasehold",
            ConstructionStatus = "Ready",
            HasPool = false,
            HasElevator = true,
            FloorCount = 2
        };

        var dealSale = new Deal
        {
            Id = 1,
            TotalPrice = 520000,
            HaveOffer = true,
            FinalTotalPrice = 500000,
            IsExchangeable = false,
            DealTypeId = 1
        };

        var dealRent = new Deal
        {
            Id = 2,
            MonthlyPayment = 1200,
            TotalPrice = 1200,
            HaveOffer = true,
            FinalMonthlyPayment = 1100,
            FinalTotalPrice = 1100,
            IsExchangeable = false,
            DealTypeId = 2
        };

        var advertisements = new List<Advertisement>
        {
            new()
            {
                Id = 1,
                TitleEn = "Luxury Villa in Al Khuwair",
                TitleFa = "ویلا لوکس در الخویر",
                TitleAr = "فيلا فاخرة في الخوير",
                DescriptionEn = "A premium villa with pool and garden.",
                DescriptionFa = "ویلا لوکس با استخر و باغ.",
                DescriptionAr = "فيلا مميزة مع مسبح وحديقة.",
                HouseId = 1,
                DealId = 1,
                Keywords = new List<Keyword> { keywords[0], keywords[2] }
            },
            new()
            {
                Id = 2,
                TitleEn = "Modern Apartment in Al Mouj",
                TitleFa = "آپارتمان مدرن در الموج",
                TitleAr = "شقة حديثة في الموج",
                DescriptionEn = "Sea-view apartment for rent.",
                DescriptionFa = "آپارتمان با منظره دریا برای اجاره.",
                DescriptionAr = "شقة مطلة على البحر للإيجار.",
                HouseId = 2,
                DealId = 2,
                Keywords = new List<Keyword> { keywords[1] }
            }
        };

        var agents = new List<Agent>
        {
            new() { Id = 1, NameEn = "Ahmad Al Harthy", NameFa = "احمد الحارثی", NameAr = "أحمد الحارثي", ExpertEn = "Sales Consultant", ExpertFa = "مشاور فروش", ExpertAr = "مستشار مبيعات", ImageAddress = "/images/agent-1.jpg" },
            new() { Id = 2, NameEn = "Sara Al Lawati", NameFa = "سارا اللواتی", NameAr = "سارة اللواتي", ExpertEn = "Property Advisor", ExpertFa = "مشاور ملک", ExpertAr = "مستشارة عقارية", ImageAddress = "/images/agent-2.jpg" },
            new() { Id = 3, NameEn = "Yousef Al Busaidi", NameFa = "یوسف البوسعیدی", NameAr = "يوسف البوسعيدي", ExpertEn = "Rental Specialist", ExpertFa = "متخصص اجاره", ExpertAr = "متخصص إيجارات", ImageAddress = "/images/agent-3.jpg" },
            new() { Id = 4, NameEn = "Maha Al Nabhani", NameFa = "ماها النبهانی", NameAr = "ماها النبهاني", ExpertEn = "Investment Advisor", ExpertFa = "مشاور سرمایه‌گذاری", ExpertAr = "مستشارة استثمار", ImageAddress = "/images/agent-4.jpg" }
        };

        var articles = new List<Article>
        {
            new() { Id = 1, TitleEn = "How to Buy Property in Muscat", TitleFa = "چگونه در مسقط ملک بخریم", TitleAr = "كيف تشتري عقارًا في مسقط", SummaryEn = "A quick guide for first-time buyers.", SummaryFa = "راهنمای سریع برای خریداران اول.", SummaryAr = "دليل سريع للمشترين لأول مرة.", ContentEn = "Buying in Oman starts with the right research.", ContentFa = "خرید در عمان با تحقیق درست آغاز می‌شود.", ContentAr = "يبدأ الشراء في عمان بالبحث الصحيح.", AuthorName = "Editorial Team", ImageAddress = "/images/blog-1.jpg", PublishedAt = DateTime.UtcNow.AddDays(-2), IsPublished = true },
            new() { Id = 2, TitleEn = "Best Areas for Rental Homes", TitleFa = "بهترین مناطق برای اجاره خانه", TitleAr = "أفضل المناطق لإيجار المنازل", SummaryEn = "Where tenants are looking this year.", SummaryFa = "امسال مستأجران به دنبال کجا هستند.", SummaryAr = "أين يبحث المستأجرون هذا العام.", ContentEn = "The rental market is shifting toward waterfront communities.", ContentFa = "بازار اجاره به سمت مناطق ساحلی در حال حرکت است.", ContentAr = "يتحول سوق الإيجار نحو المجتمعات المطلة على البحر.", AuthorName = "Editorial Team", ImageAddress = "/images/blog-2.jpg", PublishedAt = DateTime.UtcNow.AddDays(-5), IsPublished = true },
            new() { Id = 3, TitleEn = "Oman Real Estate Outlook", TitleFa = "چشم‌انداز املاک عمان", TitleAr = "آفاق العقارات في عمان", SummaryEn = "Market trends and opportunities.", SummaryFa = "روندها و فرصت‌های بازار.", SummaryAr = "اتجاهات السوق والفرص.", ContentEn = "Investors are showing increasing interest in mixed-use developments.", ContentFa = "سرمایه‌گذاران علاقه بیشتری به پروژه‌های چندمنظوره نشان می‌دهند.", ContentAr = "يظهر المستثمرون اهتمامًا متزايدًا بالمشاريع متعددة الاستخدامات.", AuthorName = "Editorial Team", ImageAddress = "/images/blog-3.jpg", PublishedAt = DateTime.UtcNow.AddDays(-8), IsPublished = true },
            new() { Id = 4, TitleEn = "Preparing a Home for Sale", TitleFa = "آماده‌سازی خانه برای فروش", TitleAr = "تهيئة المنزل للبيع", SummaryEn = "Improve value before listing.", SummaryFa = "قبل از ثبت آگهی ارزش را بالا ببرید.", SummaryAr = "حسّن القيمة قبل الإدراج.", ContentEn = "Presentation matters when marketing a property.", ContentFa = "نحوه ارائه ملک در بازاریابی بسیار مهم است.", ContentAr = "طريقة عرض العقار مهمة في التسويق.", AuthorName = "Editorial Team", ImageAddress = "/images/blog-4.jpg", PublishedAt = DateTime.UtcNow.AddDays(-11), IsPublished = true }
        };

        await db.AddRangeAsync(homeGroup);
        await db.AddRangeAsync(statuses);
        await db.AddRangeAsync(staticDatas);
        await db.AddRangeAsync(keywords);
        await db.AddRangeAsync(materials);
        await db.AddRangeAsync(house, house2);
        await db.AddRangeAsync(dealSale, dealRent);
        await db.AddRangeAsync(advertisements);
        await db.AddRangeAsync(agents);
        await db.AddRangeAsync(articles);

        var floor = new Floor
        {
            Id = 1,
            Area = 310,
            RoomCount = 4,
            Capacity = 6,
            HasBalcony = true,
            BalconyArea = 18,
            HasStorage = true,
            StorageArea = 8,
            ConstructionDirection = "South",
            CoolingStatus = "Central AC",
            HeatingStatus = "Standard",
            HotWaterStatus = "Available",
            ToiletTypeId = 4,
            HouseId = 1,
            FloorMaterials = new List<Material> { materials[0], materials[1] }
        };

        var image = new HouseImage { Id = 1, HouseId = 1, ImageAddress = "/images/property-1.jpg" };

        await db.AddAsync(floor);
        await db.AddAsync(image);
        await db.SaveChangesAsync();
    }
}
