using System;
using System.Collections.Generic;

namespace AppAnimeTitles.Models;

public partial class TitlesGenre
{
    public int Id { get; set; }

    public short IdGenres { get; set; }

    public int IdAnime { get; set; }

    //Навигационные свойства
    public virtual AnimeTitle AnimeTitle { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;
}
