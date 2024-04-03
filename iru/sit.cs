// Optimized and expanded code
var filteredParts = partsList.Where(part => part.Length >= 3)
                             .ToList();
