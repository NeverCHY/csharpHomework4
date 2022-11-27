using System;
namespace weather;
public delegate string[] Message(Logger l);
public class Logger
{
    public string time;
    public string tem;//温度 
    public string hum;//湿度
    public Logger(string time, string tem, string hum)
    {
        this.time = time;
        this.tem = tem;
        this.hum = hum;
    }
    public Message WriteMessage { get; set; }
    public void LogMessage(string s)
    {
        Console.WriteLine(s);
    }
}
public class LoggerData //数据保存类
{
    public string[] LogToSave(Logger l)
    {
        string[] s = { l.time, l.tem, l.hum };
        return s;
    }
}
class ConsoleLogger //屏幕显示类
{
    public string[] LogToConsole(Logger l)
    {
        string[] s = { l.time, l.tem, l.hum };
        return s;
    }
}
class Program
{
    static void Main(string[] args)
    {
        string[] ss = { "时间：", "温度：", "湿度：" };
        Logger logger = new Logger("10：00", "28℃", "42%");
        ConsoleLogger cl = new ConsoleLogger();
        LoggerData fl = new LoggerData();
        logger.LogMessage("程序开始运行");
        logger.LogMessage("显示气象信息: ");
        logger.WriteMessage += cl.LogToConsole;
        string[] s = logger.WriteMessage(logger);
        for (int i = 0, j = 0; i < ss.Length && j < s.Length; i++, j++)
            Console.WriteLine(ss[i] + s[i]);
        logger.LogMessage("已保存气象信息");
        logger.WriteMessage += cl.LogToConsole;
    }
}

