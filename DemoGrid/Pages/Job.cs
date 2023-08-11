public class CadJobDto
{
    public int? cadSoftwareId { get; set; }
    public CadSoftware cadSoftware { get; set; }
    public string errorMessage { get; set; }
    public int? cadSoftwareAutomationJobPriority { get; set; }
    public int? cadSoftwareAutomationJobStatus { get; set; }
    public int? configurationId { get; set; }
    public int? revisionId { get; set; }
    public string tcsFileName { get; set; }
    public string environment { get; set; }
    public string storage { get; set; }
    public DateTime? queuedOn { get; set; }
    public DateTime? estimatedTDelivery { get; set; }
    public int Id { get; set; }
    public string createdBy { get; set; }
    public DateTime? createdOn { get; set; }
    public string modifiedBy { get; set; }
    public DateTime? modifiedOn { get; set; }
}

public class CadSoftware
{
    public string name { get; set; }
    public object cadServers { get; set; }
    public int Id { get; set; }
    public string createdBy { get; set; }
    public DateTime createdOn { get; set; }
    public object modifiedBy { get; set; }
    public DateTime modifiedOn { get; set; }
}