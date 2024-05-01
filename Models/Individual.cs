namespace Models
{
    public class Individual
    {
        public List<IndMessage>? Message { get; set; }
    }

    public class IndMessage
    {
        public string? IndividualId { get; set; }
        public string? IndividualFName { get; set; }
        public string? IndividualLName { get; set; }
        public long? IndividualStatus { get; set; }
        public long IndividualSex { get; set; }
        public long UserId { get; set; }
        public string? LocalId { get; set; }
        public long Piid { get; set; }
        public DateTimeOffset DateAdd { get; set; }
        public string? RelevantClinicalInfo { get; set; }
        public string? IndividualBirthDate { get; set; }
        public long? Age { get; set; }
        public List<object>? Phenotype { get; set; }
    }
}
