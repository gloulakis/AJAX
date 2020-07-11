namespace AjaxWebApi.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class ChessFigure
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Power { get; set; }

        public int MinRange { get; set; }

        public int MaxRange { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
