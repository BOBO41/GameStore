using System;

namespace GameStore.Application.DTOS.Developers
{
    public class AddOrUpdateDeveloperDTO {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public string Country { get; set; }
    }
}