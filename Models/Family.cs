namespace Models
{
    public class Family
    {
        public List<FMessage>? Message { get; set; }
    }

    public class FMessage
    {
        public string? FamilyId { get; set; }
        public string? FamilyDesc { get; set; }
        public long? UserId { get; set; }
        public string? IndividualId { get; set; }
        public string? LocalId { get; set; }
        public string? IndividualFName { get; set; }
        public string? IndividualLName { get; set; }
        public long Piid { get; set; }
        public DateTimeOffset DateAdd { get; set; }
    }
}
