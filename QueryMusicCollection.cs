
using MusicGraphQL;

public class QueryMusicCollection
{
    public MusicCollection GetMusicCollection()
    {
        var musicCollection = MusicCollectionService.FromJson();
        return musicCollection;
    }
}