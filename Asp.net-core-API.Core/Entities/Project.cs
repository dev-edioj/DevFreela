using Asp.net_core_API.Core.Enums;

namespace Asp.net_core_API.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idCliente, int idFreelancer, decimal totalCost)
        {
            Title = title;
            Description = description;
            IdClient = idCliente;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;
            
            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = new List<ProjectComment>();
        }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal TotalCost { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }
    }
}