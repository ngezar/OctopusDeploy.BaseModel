/*
 * Create date: 24-Aug-2024
 * Create by: Nge Zar
 * Reason: Octopus Deploy Interview Assessment Purpose
 */

namespace OctopusDeploy.BaseModel
{
    public class Deployment
    {
        public string Id { get; set; }
        public string ReleaseId { get; set; }
        public string EnvironmentId { get; set; }
        public string DeployedAt { get; set; }

    }
}
