﻿using MongoDB.Driver;

namespace GF.UCenter.MongoDB.Database
{
    public interface IMongoContext
    {
        IMongoDatabase GetDatabase();
    }
}
