﻿using RoguePanda.entity.color;

namespace RoguePanda.entity {
    public interface ISpriteEntity {
        string assetID { get; set; }
        EntityColor color { get; }
        byte alpha { get; set; }
        int width { get; set; }
        int height { get; set; }
        float rotation { get; set; }
        float scaleX { get; set; }
        float scaleY { get; set; }
        float x { get; set; }
        float y { get; set; }
        int texPosX { get; set; }
        int texPosY { get; set; }
        float layer { get; set; }
    }
}
