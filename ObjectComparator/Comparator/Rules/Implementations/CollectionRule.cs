﻿using System.Collections.Generic;
using ObjectsComparator.Comparator.Strategies.Implementations.Collections;
using ObjectsComparator.Helpers.Extensions;

namespace ObjectsComparator.Comparator.Rules.Implementations
{
    public class CollectionRule : Rule<BaseCollectionsCompareStrategy>
    {
        public CollectionRule(Comparator comparator, BaseCollectionsCompareStrategy defaultRule) : base(
            defaultRule) => Strategies.ForEach(s => s.Comparator = comparator);

        public CollectionRule(Comparator comparator, BaseCollectionsCompareStrategy defaultRule,
            IList<BaseCollectionsCompareStrategy> others) : base(defaultRule, others) => Strategies.ForEach(s => s.Comparator = comparator);
    }
}