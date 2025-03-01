namespace EvDevSharp;

public enum EvDevRelativeAxisCode
{
    REL_X = 0x00,
    REL_Y = 0x01,
    REL_Z = 0x02,
    REL_RX = 0x03,
    REL_RY = 0x04,
    REL_RZ = 0x05,
    REL_HWHEEL = 0x06,
    REL_DIAL = 0x07,
    REL_WHEEL = 0x08,
    REL_MISC = 0x09,
    REL_MAX = 0x0f,
    REL_CNT = (REL_MAX + 1),
}