using MasqatGate.Models;

namespace MasqatGate.Extensions;

public static class AgentExtensions
{
    public static string LocalizedName(this Agent? agent, string lang)
    {
        if (agent == null) return string.Empty;

        return lang switch
        {
            "fa" => agent.NameFa ?? agent.NameEn ?? string.Empty,
            "ar" => agent.NameAr ?? agent.NameEn ?? string.Empty,
            _ => agent.NameEn ?? agent.NameFa ?? string.Empty
        };
    }

    public static string LocalizedExpert(this Agent? agent, string lang)
    {
        if (agent == null) return string.Empty;

        return lang switch
        {
            "fa" => agent.ExpertFa ?? agent.ExpertEn ?? string.Empty,
            "ar" => agent.ExpertAr ?? agent.ExpertEn ?? string.Empty,
            _ => agent.ExpertEn ?? agent.ExpertFa ?? string.Empty
        };
    }
}

public static class ArticleExtensions
{
    public static string LocalizedTitle(this Article? article, string lang)
    {
        if (article == null) return string.Empty;

        return lang switch
        {
            "fa" => article.TitleFa ?? article.TitleEn ?? string.Empty,
            "ar" => article.TitleAr ?? article.TitleEn ?? string.Empty,
            _ => article.TitleEn ?? article.TitleFa ?? string.Empty
        };
    }

    public static string LocalizedSummary(this Article? article, string lang)
    {
        if (article == null) return string.Empty;

        return lang switch
        {
            "fa" => article.SummaryFa ?? article.SummaryEn ?? string.Empty,
            "ar" => article.SummaryAr ?? article.SummaryEn ?? string.Empty,
            _ => article.SummaryEn ?? article.SummaryFa ?? string.Empty
        };
    }

    public static string LocalizedContent(this Article? article, string lang)
    {
        if (article == null) return string.Empty;

        return lang switch
        {
            "fa" => article.ContentFa ?? article.ContentEn ?? string.Empty,
            "ar" => article.ContentAr ?? article.ContentEn ?? string.Empty,
            _ => article.ContentEn ?? article.ContentFa ?? string.Empty
        };
    }
}

public static class StaticDataExtensions
{
    public static string LocalizedContent(this StaticData? adv, string lang)
    {
        if (adv == null) return string.Empty;

        return lang switch
        {
            "fa" => adv.StringContentFa ?? adv.StringContentEn ?? "بدون محتوا",
            "ar" => adv.StringContentAr ?? adv.StringContentEn ?? "بدون محتوا",
            _ => adv.StringContentEn ?? adv.StringContentFa ?? "No Content"
        };
    }
}
