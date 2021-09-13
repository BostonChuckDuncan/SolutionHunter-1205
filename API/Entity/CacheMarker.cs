namespace API.Entity
{
    public class CacheMarker
    {  
        public int Id { get; set; }
        public string MarkerName { get; set; }
        public int StartId { get; set; }        // starting record for range of interest
        public int StartOffset { get; set; }    // offset within the starting record
        public int EndId { get; set; }          // last record this project allocated from
        public int EndOffset { get; set; }      // last offset within that record
        public int LastId { get; set; }         // in Record 1, last known record in pool
        public int ProjId { get; set; }         // for non-record 1, ProjectId the range is for
        public string GhostId { get; set; }   // used in self-improvement learning
    }

}