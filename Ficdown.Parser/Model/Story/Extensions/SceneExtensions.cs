﻿namespace Ficdown.Parser.Model.Story.Extensions
{
    using System.Collections.Generic;

    public static class SceneExtensions
    {
        public static Scene Clone(this Scene scene)
        {
            return new Scene
            {
                Name = scene.Name,
                Description = scene.Description,
                Conditions = new List<string>(scene.Conditions)
            };
        }
    }
}
