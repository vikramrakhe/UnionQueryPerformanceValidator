﻿using System.Collections.Generic;

namespace UnionQueryPerformanceValidator
{
    public class StringQueryStore
    {
        private static readonly string SingleUnionQuery =
            "select PUID from (select PUID from pitem where rownum < 5 UNION ALL select PUID from pitemrevision where rownum < 5 UNION ALL select PUID from pworkspaceobject where rownum < 5 UNION ALL select PUID from ppom_application_object where rownum < 5 UNION ALL select PUID from PImanRelation where rownum < 5 ) order by PUID";

        private static readonly string[] MultiQueriesStore =
        {
            "select PUID from pitem where rownum < 5",
            "select PUID from pitemrevision where rownum< 5",
            "select PUID from pworkspaceobject where rownum < 5",
            "select PUID from ppom_application_object where rownum< 5",
            "select PUID from PImanRelation where rownum < 5"
        };

        public string ReadSingleUnionQuery()
        {
            return SingleUnionQuery;
        }

        public IEnumerable<string> ReadQueriesFromStore()
        {
            return MultiQueriesStore;
        }
    }
}
