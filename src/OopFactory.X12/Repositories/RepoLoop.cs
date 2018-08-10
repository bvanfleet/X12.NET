﻿namespace OopFactory.X12.Repositories
{
    using System;

    using OopFactory.X12.Shared.Models;

    [Obsolete("Use OopFactory.X12.Sql library and namespace")]
	public class RepoLoop<T> where T : struct
    {
        public RepoLoop(string segmentString, char segmentTerminator, char elementSeparator, char componentSeparator)
        {
            this.Segment = new DetachedSegment(new X12DelimiterSet(segmentTerminator, elementSeparator, componentSeparator), segmentString);
        }

        public T LoopId { get; set; }
        public T? ParentLoopId { get; set; }
        public T InterchangeId { get; set; }
        public T TransactionSetId { get; set; }
        public string TransactionSetCode { get; set; }
        public string SpecLoopId { get; set; }
        public string LevelId { get; set; }
        public string LevelCode { get; set; }
        public string StartingSegmentId { get; set; }
        public string EntityIdentifierCode { get; set; }
        public int RevisionId { get; set; }
        public int PositionInInterchange { get; set; }
        public DetachedSegment Segment { get; private set; }

    }
}
