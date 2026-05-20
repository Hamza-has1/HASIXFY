namespace MyPortfolio.Services
{
    public class SiteDataService
    {
        public string HeroName { get; set; } = "HASXIFY";
        public string HeroBadge { get; set; } = "Content Creator";
        public string HeroTitle { get; set; } = "Where Content Meets Creativity";
        public string HeroDesc { get; set; } = "I create content that breaks boundaries, tells stories, and builds communities. From viral videos to digital courses — this is where the magic happens.";
        public string ContactEmail { get; set; } = "contact@hasxify.com";
        public string ContactPhone { get; set; } = "+92 300 0000000";
        public string ContactCity { get; set; } = "Karachi, Pakistan";
        public string ContactHours { get; set; } = "Mon-Sat: 9AM - 6PM";

        public List<SocialItem> SocialMedia { get; set; } = new()
        {
            new SocialItem { Platform = "Instagram", Icon = "📸", Handle = "@hasxify", Followers = "10K+", Posts = "200+", Url = "https://instagram.com/hasxify" },
            new SocialItem { Platform = "LinkedIn", Icon = "💼", Handle = "HASXIFY Official", Followers = "5K+", Posts = "50+", Url = "https://linkedin.com/in/hasxify" },
            new SocialItem { Platform = "YouTube", Icon = "▶️", Handle = "HASXIFY", Followers = "8K+", Posts = "100+", Url = "https://youtube.com/@hasxify" },
            new SocialItem { Platform = "Twitter/X", Icon = "🐦", Handle = "@hasxify", Followers = "3K+", Posts = "1K+", Url = "https://twitter.com/hasxify" },
            new SocialItem { Platform = "Facebook", Icon = "📘", Handle = "HASXIFY Page", Followers = "7K+", Posts = "300+", Url = "https://facebook.com/hasxify" },
            new SocialItem { Platform = "TikTok", Icon = "🎵", Handle = "@hasxify", Followers = "20K+", Posts = "500K+", Url = "https://tiktok.com/@hasxify" },
        };

        public List<CourseItem> Courses { get; set; } = new()
        {
            new CourseItem { Name = "Content Creation Masterclass", Price = "PKR 4,999", Tag = "Bestseller", Icon = "🚀", Description = "Everything you need to go from zero to viral." },
            new CourseItem { Name = "Social Media Growth Blueprint", Price = "PKR 3,499", Tag = "New", Icon = "📈", Description = "The exact system to grow from 0 to 10K+ followers." },
            new CourseItem { Name = "Personal Branding Bootcamp", Price = "PKR 2,999", Tag = "Popular", Icon = "💡", Description = "Build a brand that people remember." },
            new CourseItem { Name = "Video Editing Pro", Price = "PKR 5,999", Tag = "Advanced", Icon = "🎬", Description = "Master video editing for YouTube, Reels and TikTok." },
            new CourseItem { Name = "Monetization Secrets", Price = "PKR 6,999", Tag = "Hot", Icon = "💰", Description = "Turn your content into a full-time income." },
            new CourseItem { Name = "Creator Starter Kit", Price = "FREE", Tag = "Free", Icon = "🎯", Description = "Free beginner course to get you started." },
        };

        public List<ServiceItem> Services { get; set; } = new()
        {
            new ServiceItem { Name = "Video Production", Icon = "🎬", Description = "Professional video content for YouTube, Reels, TikTok and all major platforms." },
            new ServiceItem { Name = "Social Media Management", Icon = "📱", Description = "Full management of your social media presence." },
            new ServiceItem { Name = "Brand Identity", Icon = "🎨", Description = "Building a visual identity that makes you unforgettable." },
            new ServiceItem { Name = "Content Strategy", Icon = "📊", Description = "Data-driven content plans that grow your audience." },
        };

        public List<PackageItem> Packages { get; set; } = new()
        {
            new PackageItem { ServiceName = "Video Production", BasicPrice = "PKR 15,000", ProPrice = "PKR 35,000", PremiumPrice = "Custom" },
            new PackageItem { ServiceName = "Social Media Management", BasicPrice = "PKR 20,000", ProPrice = "PKR 45,000", PremiumPrice = "PKR 80,000" },
            new PackageItem { ServiceName = "Brand Identity", BasicPrice = "PKR 25,000", ProPrice = "PKR 55,000", PremiumPrice = "PKR 90,000" },
            new PackageItem { ServiceName = "Content Strategy", BasicPrice = "PKR 18,000", ProPrice = "PKR 40,000", PremiumPrice = "PKR 75,000" },
        };

        public event Action? OnChange;
        public void NotifyChanged() => OnChange?.Invoke();
    }

    public class SocialItem
    {
        public string Platform { get; set; } = "";
        public string Icon { get; set; } = "";
        public string Handle { get; set; } = "";
        public string Followers { get; set; } = "";
        public string Posts { get; set; } = "";
        public string Url { get; set; } = "";
    }

    public class CourseItem
    {
        public string Name { get; set; } = "";
        public string Price { get; set; } = "";
        public string Tag { get; set; } = "";
        public string Icon { get; set; } = "";
        public string Description { get; set; } = "";
    }

    public class ServiceItem
    {
        public string Name { get; set; } = "";
        public string Icon { get; set; } = "";
        public string Description { get; set; } = "";
    }

    public class PackageItem
    {
        public string ServiceName { get; set; } = "";
        public string BasicPrice { get; set; } = "";
        public string ProPrice { get; set; } = "";
        public string PremiumPrice { get; set; } = "";
    }
}