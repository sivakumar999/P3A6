﻿using System;
using System.Collections.Generic;

namespace BookStore.Models;

public partial class Publisher
{
    public int Id { get; set; }

    public string? PublisherName { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
