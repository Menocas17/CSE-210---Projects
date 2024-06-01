using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Test1", "tester1", "1:34");
        video1.AddComments("cTest1:", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque lectus ipsum, interdum id purus vitae, pretium vehicula leo. Sed volutpat arcu ullamcorper risus vehicula tempus.", 4);
        _videos.Add(video1);

        Video video2 = new Video("Test2", "tester2", "3:54");
        video2.AddComments("cTest2", "uspendisse potenti. Phasellus consequat est sed ipsum finibus aliquam.", 5);
        _videos.Add(video2);

        Video video3 = new Video("Test3", "tester3", "2:30");
        video3.AddComments("cTest3", "ac tincidunt lacus sodales vitae. Nunc placerat ligula nec elit tincidunt egestas. Nam arcu purus, ultricies et leo id, ornare lobortis diam. Morbi quam lacus, malesuada in magna sit amet", 5);
        _videos.Add(video3);

        Video video4 = new Video("Test4", "tester4", "5:37");
        video4.AddComments("cTest4", "Class aptent taciti sociosqu ad litora torquent per conubia nostra", 10);
        _videos.Add(video4);


        foreach(Video video in _videos)
        {
            video.DisplayVideoInfo();
        }



    }
}