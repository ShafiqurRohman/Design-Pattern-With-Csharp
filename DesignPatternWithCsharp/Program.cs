using System;
using DesignPatternWithCsharp.FactoryPattern;
using DesignPatternWithCsharp.AbstractFactoryPattern;
using DesignPatternWithCsharp.SingletonPattern;
using DesignPatternWithCsharp.BuilderPattern;
using DesignPatternWithCsharp.PrototypePattern;
using DesignPatternWithCsharp.AdapterPattern;
using DesignPatternWithCsharp.BridgePattern;
using DesignPatternWithCsharp.CompositePattern;
using DesignPatternWithCsharp.ObserverPattern;
using DesignPatternWithCsharp.FilterPattern;

namespace DesignPatternWithCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FactoryPattern
            //FactoryPattern.ShapeFactory shapeFactory = new FactoryPattern.ShapeFactory();
            //shapeFactory.GetShape("CIRCLE").draw();
            //shapeFactory.GetShape("rectangle").draw();
            #endregion

            #region AbstractFactoryPattern
            //FactoryProducer.getFactory(true).GetShape("ROUNDEDRACTANGLE").draw();
            //FactoryProducer.getFactory(false).GetShape("Rectangle").draw();
            #endregion

            #region SingletonPattern
            //Singelton checkObj = Singelton.getSingeltonObj;
            //Singelton checkObj2 = Singelton.getSingeltonObj;
            //Singelton checkObj3 = Singelton.getSingeltonObj;
            #endregion

            #region BuilderPattern
            //MealBuilder mealbuilder = new MealBuilder();
            //Meal meal1 = mealbuilder.prepareNoneVegMeal();
            //meal1.showItem();

            //Meal meal2 = mealbuilder.prepareVegMeal();
            //meal2.showItem();
            #endregion

            #region AdpaterPattern
            //AudioPlayer audioPlayer = new AudioPlayer();
            //audioPlayer.play("mp3", "para nai chil.mp3");
            //audioPlayer.play("mp4", "alone.mp4");
            //audioPlayer.play("vlc", "far far away.vlc");
            //audioPlayer.play("avi", "mind me.avi");
            #endregion

            #region PrototypePattern
            //ShapeCache.loadCache();
            //PrototypePattern.Shape cloneShape = ShapeCache.getShape("1");
            //cloneShape.draw();

            //PrototypePattern.Shape cloneShape2 = ShapeCache.getShape("2");
            //cloneShape2.draw();
            #endregion

            #region BridgePattern
            //BridgePattern.Shape redCircle = new BridgePattern.Circle(100, 100, 10, new RedCircle());
            //BridgePattern.Shape greenCircle = new BridgePattern.Circle(100, 100, 12, new GreenCircle());
            //redCircle.draw();
            //greenCircle.draw();
            #endregion

            #region CompositePattern
            //CompositePatternDemo.demo();
            #endregion

            #region ObserverPattern

            //Subject subject = new Subject();
            //new HexaObserver(subject);
            //new OctalObserver(subject);
            //new BinaryObserver(subject);

            //Console.WriteLine("First state change:15");
            //subject.setState(15);
            //Console.WriteLine("Second state change:10");
            //subject.setState(9);

            #endregion

            #region FilterPattern
                FilterPatternDemo.demo();
            #endregion
        }
    }
}
