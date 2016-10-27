using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;


namespace UnionQueryPerformanceValidator
{
    public class QueryResultProcessor
    {
        public ConcurrentBag<ResultRow> ResultRowSet;
        public List<ResultRow> OrderedResultSet;

        public QueryResultProcessor()
        {
            ResultRowSet = new ConcurrentBag<ResultRow>();
            OrderedResultSet = new List<ResultRow>();
        }
        
        public void AddToRowSet(ResultRow row)
        {
            ResultRowSet.Add(row);
        }

        public void OrderBy()
        {
           OrderedResultSet = ResultRowSet.OrderByDescending(o => o.PUID).ToList();
        }

        public override string ToString() => string.Join(",", OrderedResultSet.Select(o => o.PUID).ToArray());

        public string GetString() => string.Join(",", ResultRowSet.Select(o => o.PUID).ToArray());
        public void Clear()
        {
            if (!ResultRowSet.IsEmpty)
                ResultRowSet = new ConcurrentBag<ResultRow>();

            OrderedResultSet.Clear();
        }
    };

    public class ResultRow : IEquatable<ResultRow>
    {
        public bool Equals(ResultRow other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(PUID, other.PUID);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ResultRow) obj);
        }

        public override int GetHashCode()
        {
            return (PUID != null ? PUID.GetHashCode() : 0);
        }

        public static bool operator ==(ResultRow left, ResultRow right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResultRow left, ResultRow right)
        {
            return !Equals(left, right);
        }

        public ResultRow( string uid )
        {
            PUID = uid;
        }
        public string  PUID { get; }
    };
}
