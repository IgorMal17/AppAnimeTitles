using System;
using System.Collections.Generic;

namespace AppAnimeTitles.Models;

public partial class Genre
{
    public short Id { get; set; }

    public string GenreName { get; set; } = null!;

    //Навигационные свойства
    public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();
}
