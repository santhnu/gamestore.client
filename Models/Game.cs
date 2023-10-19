using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace GameStore.Client.Models;

public class Game
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string Name { get; set; }

    [Required]
    [StringLength(20)]
    public required string Genre { get; set; }

    [Range(1, 100)]
    public decimal Price { get; set; }

    [Range(0, 100)]
    public decimal RetailPrice { get; set; }

    public DateTime ReleaseDate { get; set; }

    public required string ImageUri { get; set; }
}
