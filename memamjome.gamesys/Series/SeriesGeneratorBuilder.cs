namespace memamjome.gamesys.Series
{
    class SeriesGeneratorBuilder
    {
        public ISeriesGenerator GetSeriesGenerator()
        {
            return new SeriesGuard(new SeriesDeduplicator(new SeriesRounderGenerator(new SeriesGenerator())));
        }
    }
}
