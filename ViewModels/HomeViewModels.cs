using MasqatGate.Models;

namespace MasqatGate.ViewModels;

public class HomeViewModel
{
    public int advertisementsCount { get; set; }
    public List<Advertisement> advertisements { get; set; } = new();
    public List<StaticData> staticDatas { get; set; } = new();
    public List<Agent> agents { get; set; } = new();
    public List<Article> articles { get; set; } = new();
}

public class aboutViewModel
{
    public List<StaticData> staticDatas { get; set; } = new();
}

public class agentViewModel
{
    public List<StaticData> staticDatas { get; set; } = new();
    public List<Agent> agents { get; set; } = new();
}

public class blogViewModel
{
    public List<StaticData> staticDatas { get; set; } = new();
    public List<Article> articles { get; set; } = new();
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 8;
    public int TotalCount { get; set; }
    public int TotalPages => PageSize <= 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize);
}

public class blogSingleViewModel
{
    public List<StaticData> staticDatas { get; set; } = new();
    public Article? article { get; set; }
    public List<Article> recentArticles { get; set; } = new();
}

public class contactViewModel
{
    public List<StaticData> staticDatas { get; set; } = new();
}

public class propertiesViewModel
{
    public List<StaticData> staticDatas { get; set; } = new();
    public List<Advertisement> advertisements { get; set; } = new();
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 9;
    public int TotalCount { get; set; }
    public int TotalPages => PageSize <= 0 ? 0 : (int)Math.Ceiling((double)TotalCount / PageSize);
}

public class propertiesSingleViewModel
{
    public List<StaticData> staticDatas { get; set; } = new();
    public Advertisement? advertisement { get; set; }
    public List<Advertisement> relatedAdvertisements { get; set; } = new();
}

public class servicesViewModel
{
    public List<StaticData> staticDatas { get; set; } = new();
}
