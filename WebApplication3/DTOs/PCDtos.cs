namespace WebApplication3.DTOs;

public class PCListDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Weight { get; set; }
    public int Warranty { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Stock { get; set; }
}

public class PCCreateUpdateDto
{
    public string Name { get; set; } = string.Empty;
    public double Weight { get; set; }
    public int Warranty { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Stock { get; set; }
}

public class PCDetailDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Weight { get; set; }
    public int Warranty { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Stock { get; set; }
    public List<PCComponentDto> Components { get; set; } = new();
}

public class PCComponentDto
{
    public int Amount { get; set; }
    public ComponentDto Component { get; set; } = null!;
}

public class ComponentDto
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ManufacturerDto Manufacturer { get; set; } = null!;
    public TypeDto Type { get; set; } = null!;
}

public class ManufacturerDto
{
    public int Id { get; set; }
    public string Abbreviation { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public DateTime FoundationDate { get; set; }
}

public class TypeDto
{
    public int Id { get; set; }
    public string Abbreviation { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}