using System.ComponentModel.DataAnnotations;

namespace WebSite.Models;

public class Advertisement
{
    public int Id { get; set; }
    public string TitleFa { get; set; } = string.Empty;
    public string TitleEn { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;

    public string DescriptionFa { get; set; } = string.Empty;
    public string DescriptionEn { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;

    public int HouseId { get; set; }
    public House? House { get; set; }

    public int DealId { get; set; }
    public Deal? Deal { get; set; }

    public List<Keyword> Keywords { get; set; } = new();
}

public class Agent
{
    public int Id { get; set; }

    public string NameFa { get; set; } = string.Empty;
    public string NameEn { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;

    public string ExpertFa { get; set; } = string.Empty;
    public string ExpertEn { get; set; } = string.Empty;
    public string ExpertAr { get; set; } = string.Empty;

    public string ImageAddress { get; set; } = string.Empty;
}

public class Article
{
    public int Id { get; set; }

    public string TitleFa { get; set; } = string.Empty;
    public string TitleEn { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;

    public string SummaryFa { get; set; } = string.Empty;
    public string SummaryEn { get; set; } = string.Empty;
    public string SummaryAr { get; set; } = string.Empty;

    public string ContentFa { get; set; } = string.Empty;
    public string ContentEn { get; set; } = string.Empty;
    public string ContentAr { get; set; } = string.Empty;

    public string AuthorName { get; set; } = string.Empty;
    public string ImageAddress { get; set; } = string.Empty;
    public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
    public bool IsPublished { get; set; } = true;
}

public class Deal
{
    public int Id { get; set; }
    public decimal? DownPayment { get; set; }
    public decimal? MonthlyPayment { get; set; }
    public decimal TotalPrice { get; set; }
    public bool IsExchangeable { get; set; }

    public bool HaveOffer { get; set; }
    public decimal? FinalDownPayment { get; set; }
    public decimal? FinalMonthlyPayment { get; set; }
    public decimal FinalTotalPrice { get; set; }

    public int DealTypeId { get; set; }
    public Status? DealType { get; set; }
}

public class Floor
{
    public int Id { get; set; }
    public double Area { get; set; }
    public int RoomCount { get; set; }
    public int Capacity { get; set; }
    public bool HasBalcony { get; set; }
    public double? BalconyArea { get; set; }
    public bool HasStorage { get; set; }
    public double? StorageArea { get; set; }
    public string ConstructionDirection { get; set; } = string.Empty;
    public string CoolingStatus { get; set; } = string.Empty;
    public string HeatingStatus { get; set; } = string.Empty;
    public string HotWaterStatus { get; set; } = string.Empty;

    public int ToiletTypeId { get; set; }
    public Status? ToiletType { get; set; }

    public int HouseId { get; set; }
    public House? House { get; set; }

    public List<Material> FloorMaterials { get; set; } = new();
}

public class House
{
    public int Id { get; set; }
    public List<HouseImage> Images { get; set; } = new();
    public string? PropertyCode { get; set; }
    public string? City { get; set; }
    public string? District { get; set; }
    public string? Neighborhood { get; set; }
    public string? AddressLine { get; set; }
    public double? LandArea { get; set; }
    public double? BuildingArea { get; set; }
    public int? UnitNumber { get; set; }
    public int? YearRenovated { get; set; }
    public string? NearbyFacilities { get; set; }
    public string? AmenitiesFa { get; set; }
    public string? AmenitiesEn { get; set; }
    public string? AmenitiesAr { get; set; }
    public DateTime RegistrationTime { get; set; }
    public DateTime ConstructionTime { get; set; }
    public bool HasParking { get; set; }
    public int? ParkingCount { get; set; }
    public string Deed { get; set; } = string.Empty;
    public string ConstructionStatus { get; set; } = string.Empty;
    public bool HasPool { get; set; }
    public double? PoolArea { get; set; }
    public int? TreeCount { get; set; }
    public bool HasElevator { get; set; }
    public int? FloorCount { get; set; }

    public List<Floor> Floors { get; set; } = new();
}

public class HouseImage
{
    public int Id { get; set; }
    public string ImageAddress { get; set; } = string.Empty;
    public int HouseId { get; set; }
    public House? House { get; set; }
}

public class Keyword
{
    public int Id { get; set; }
    public string ContentFa { get; set; } = string.Empty;
    public string ContentEn { get; set; } = string.Empty;
    public string ContentAr { get; set; } = string.Empty;

    public List<Advertisement> Advertisements { get; set; } = new();
}

public class Material
{
    public int Id { get; set; }
    public string ContentFa { get; set; } = string.Empty;
    public string ContentEn { get; set; } = string.Empty;
    public string ContentAr { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public List<Floor> Floors { get; set; } = new();
}

public class StaticData
{
    [Key]
    public string Id { get; set; } = string.Empty;
    public string? StringContentFa { get; set; }
    public string? StringContentEn { get; set; }
    public string? StringContentAr { get; set; }
    public int? BestCountOfNumber { get; set; }
    public string? ImageAdress { get; set; }
    public string Name { get; set; } = string.Empty;
    public int GroupId { get; set; }
    public StaticDataGroup? Group { get; set; }
}

public class StaticDataGroup
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string Page { get; set; } = string.Empty;
    public string Container { get; set; } = string.Empty;
}

public class Status
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
}
