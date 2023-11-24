namespace SqlViewer.Dal
{
    static class RepositoryFactory
    {
        private static readonly Lazy<IRepository> repository = new(() => new SqlRepository());

        public static IRepository Repository { get { return repository.Value; } }
    }
}
