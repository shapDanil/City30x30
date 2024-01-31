using System;
public class ResourcesModel
{
    private int _wood;
    private int _gold;
    private int _food;
    private int _steel;

    public ResourcesModel(int wood, int gold, int food, int steel)
    {
        _food = food;
        _wood= wood;
        _gold = gold;
        _steel = steel;
    }

    public int Wood { get => _wood; set {
            if (value < 0)
                throw new Exception("Значение дерева меньше 0");
            else
                _wood = value;
        }
    }
    public int Gold { get => _gold; set
        {
            if (value < 0)
                throw new Exception("Значение золота меньше 0");
            else
                _gold = value;
        }
    }
    public int Food { get => _food; set
        {
            if (value < 0)
                throw new Exception("Значение еды меньше 0");
            else
                _food = value;
        }
    }
    public int Steel { get => _steel; set
        {
            if (value < 0)
                throw new Exception("Значение стали меньше 0");
            else
                _steel = value;
        }
    }
}
