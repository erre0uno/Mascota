/*
public class Blog
{
    public int BlogId { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string Url { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Rating { get; set; }
    
    [Precision(14, 2)]
    public decimal Score { get; set; }
    [Precision(3)]
    public DateTime LastUpdated { get; set; }

    
    [Required] // Data annotations needed to configure as required
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; } // Data annotations needed to configure as required

    public string MiddleName { get; set; } // Optional by convention

}

*/