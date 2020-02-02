// Material wrapper generated by shader translator tool
using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Kopernicus.Components.MaterialWrapper
{
    [SuppressMessage("ReSharper", "MemberCanBeProtected.Global")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class PQSTriplanarZoomRotation : Material
    {
        // Internal property ID tracking object
        protected class Properties
        {
            // Return the shader for this wrapper
            private const String SHADER_NAME = "Terrain/PQS/PQS Triplanar Zoom Rotation";

            public static Shader Shader
            {
                get { return Shader.Find(SHADER_NAME); }
            }

            // Factor, default = 10
            public const String FACTOR_KEY = "_factor";
            public Int32 FactorId { get; private set; }

            // Factor Blend Width, default = 0.1
            public const String FACTOR_BLEND_WIDTH_KEY = "_factorBlendWidth";
            public Int32 FactorBlendWidthId { get; private set; }

            // Factor Rotation, default = 30
            public const String FACTOR_ROTATION_KEY = "_factorRotation";
            public Int32 FactorRotationId { get; private set; }

            // Saturation, default = 1
            public const String SATURATION_KEY = "_saturation";
            public Int32 SaturationId { get; private set; }

            // Contrast, default = 1
            public const String CONTRAST_KEY = "_contrast";
            public Int32 ContrastId { get; private set; }

            // Colour Unsaturation (A = Factor), default = (1,1,1,0)
            public const String TINT_COLOR_KEY = "_tintColor";
            public Int32 TintColorId { get; private set; }

            // Specular Color, default = (0.2,0.2,0.2,0.2)
            public const String SPECULAR_COLOR_KEY = "_specularColor";
            public Int32 SpecularColorId { get; private set; }

            // Brightness, default = 2
            public const String ALBEDO_BRIGHTNESS_KEY = "_albedoBrightness";
            public Int32 AlbedoBrightnessId { get; private set; }

            // Steep Blend, default = 1
            public const String STEEP_POWER_KEY = "_steepPower";
            public Int32 SteepPowerId { get; private set; }

            // Steep Fade Start, default = 20000
            public const String STEEP_TEX_START_KEY = "_steepTexStart";
            public Int32 SteepTexStartId { get; private set; }

            // Steep Fade End, default = 30000
            public const String STEEP_TEX_END_KEY = "_steepTexEnd";
            public Int32 SteepTexEndId { get; private set; }

            // Steep Texture, default = "white" { }
            public const String STEEP_TEX_KEY = "_steepTex";
            public Int32 SteepTexId { get; private set; }

            // Steep Bump Map, default = "bump" { }
            public const String STEEP_BUMP_MAP_KEY = "_steepBumpMap";
            public Int32 SteepBumpMapId { get; private set; }

            // Steep Near Tiling, default = 1
            public const String STEEP_NEAR_TILING_KEY = "_steepNearTiling";
            public Int32 SteepNearTilingId { get; private set; }

            // Steep Far Tiling, default = 1
            public const String STEEP_TILING_KEY = "_steepTiling";
            public Int32 SteepTilingId { get; private set; }

            // Low Texture, default = "white" { }
            public const String LOW_TEX_KEY = "_lowTex";
            public Int32 LowTexId { get; private set; }

            // Low Tiling, default = 100000
            public const String LOW_TILING_KEY = "_lowTiling";
            public Int32 LowTilingId { get; private set; }

            // Mid Texture, default = "white" { }
            public const String MID_TEX_KEY = "_midTex";
            public Int32 MidTexId { get; private set; }

            // Mid Tiling, default = 100000
            public const String MID_TILING_KEY = "_midTiling";
            public Int32 MidTilingId { get; private set; }

            // Mid Bump Map, default = "bump" { }
            public const String MID_BUMP_MAP_KEY = "_midBumpMap";
            public Int32 MidBumpMapId { get; private set; }

            // Mid Bump Tiling, default = 100000
            public const String MID_BUMP_TILING_KEY = "_midBumpTiling";
            public Int32 MidBumpTilingId { get; private set; }

            // High Texture, default = "white" { }
            public const String HIGH_TEX_KEY = "_highTex";
            public Int32 HighTexId { get; private set; }

            // High Tiling, default = 100000
            public const String HIGH_TILING_KEY = "_highTiling";
            public Int32 HighTilingId { get; private set; }

            // Low Transition Start, default = 0
            public const String LOW_START_KEY = "_lowStart";
            public Int32 LowStartId { get; private set; }

            // Low Transition End, default = 0.3
            public const String LOW_END_KEY = "_lowEnd";
            public Int32 LowEndId { get; private set; }

            // High Transition Start, default = 0.8
            public const String HIGH_START_KEY = "_highStart";
            public Int32 HighStartId { get; private set; }

            // High Transition End, default = 1
            public const String HIGH_END_KEY = "_highEnd";
            public Int32 HighEndId { get; private set; }

            // AP Global Density, default = 1
            public const String GLOBAL_DENSITY_KEY = "_globalDensity";
            public Int32 GlobalDensityId { get; private set; }

            // FogColorRamp, default = "white" { }
            public const String FOG_COLOR_RAMP_KEY = "_fogColorRamp";
            public Int32 FogColorRampId { get; private set; }

            // PlanetOpacity, default = 1
            public const String PLANET_OPACITY_KEY = "_PlanetOpacity";
            public Int32 PlanetOpacityId { get; private set; }

            // Ocean Fog Dist, default = 1000
            public const String OCEAN_FOG_DISTANCE_KEY = "_oceanFogDistance";
            public Int32 OceanFogDistanceId { get; private set; }

            // Singleton instance
            private static Properties _singleton;

            public static Properties Instance
            {
                get
                {
                    // Construct the singleton if it does not exist
                    return _singleton ?? (_singleton = new Properties());
                }
            }

            private Properties()
            {
                FactorId = Shader.PropertyToID(FACTOR_KEY);
                FactorBlendWidthId = Shader.PropertyToID(FACTOR_BLEND_WIDTH_KEY);
                FactorRotationId = Shader.PropertyToID(FACTOR_ROTATION_KEY);
                SaturationId = Shader.PropertyToID(SATURATION_KEY);
                ContrastId = Shader.PropertyToID(CONTRAST_KEY);
                TintColorId = Shader.PropertyToID(TINT_COLOR_KEY);
                SpecularColorId = Shader.PropertyToID(SPECULAR_COLOR_KEY);
                AlbedoBrightnessId = Shader.PropertyToID(ALBEDO_BRIGHTNESS_KEY);
                SteepPowerId = Shader.PropertyToID(STEEP_POWER_KEY);
                SteepTexStartId = Shader.PropertyToID(STEEP_TEX_START_KEY);
                SteepTexEndId = Shader.PropertyToID(STEEP_TEX_END_KEY);
                SteepTexId = Shader.PropertyToID(STEEP_TEX_KEY);
                SteepBumpMapId = Shader.PropertyToID(STEEP_BUMP_MAP_KEY);
                SteepNearTilingId = Shader.PropertyToID(STEEP_NEAR_TILING_KEY);
                SteepTilingId = Shader.PropertyToID(STEEP_TILING_KEY);
                LowTexId = Shader.PropertyToID(LOW_TEX_KEY);
                LowTilingId = Shader.PropertyToID(LOW_TILING_KEY);
                MidTexId = Shader.PropertyToID(MID_TEX_KEY);
                MidTilingId = Shader.PropertyToID(MID_TILING_KEY);
                MidBumpMapId = Shader.PropertyToID(MID_BUMP_MAP_KEY);
                MidBumpTilingId = Shader.PropertyToID(MID_BUMP_TILING_KEY);
                HighTexId = Shader.PropertyToID(HIGH_TEX_KEY);
                HighTilingId = Shader.PropertyToID(HIGH_TILING_KEY);
                LowStartId = Shader.PropertyToID(LOW_START_KEY);
                LowEndId = Shader.PropertyToID(LOW_END_KEY);
                HighStartId = Shader.PropertyToID(HIGH_START_KEY);
                HighEndId = Shader.PropertyToID(HIGH_END_KEY);
                GlobalDensityId = Shader.PropertyToID(GLOBAL_DENSITY_KEY);
                FogColorRampId = Shader.PropertyToID(FOG_COLOR_RAMP_KEY);
                PlanetOpacityId = Shader.PropertyToID(PLANET_OPACITY_KEY);
                OceanFogDistanceId = Shader.PropertyToID(OCEAN_FOG_DISTANCE_KEY);
            }
        }

        // Is some random material this material
        public static Boolean UsesSameShader(Material m)
        {
            return m.shader.name == Properties.Shader.name;
        }

        // Factor, default = 10
        public Single Factor
        {
            get { return GetFloat(Properties.Instance.FactorId); }
            set { SetFloat(Properties.Instance.FactorId, value); }
        }

        // Factor Blend Width, default = 0.1
        public Single FactorBlendWidth
        {
            get { return GetFloat(Properties.Instance.FactorBlendWidthId); }
            set { SetFloat(Properties.Instance.FactorBlendWidthId, Mathf.Clamp(value, 0f, 0.5f)); }
        }

        // Factor Rotation, default = 30
        public Single FactorRotation
        {
            get { return GetFloat(Properties.Instance.FactorRotationId); }
            set { SetFloat(Properties.Instance.FactorRotationId, value); }
        }

        // Saturation, default = 1
        public Single Saturation
        {
            get { return GetFloat(Properties.Instance.SaturationId); }
            set { SetFloat(Properties.Instance.SaturationId, value); }
        }

        // Contrast, default = 1
        public Single Contrast
        {
            get { return GetFloat(Properties.Instance.ContrastId); }
            set { SetFloat(Properties.Instance.ContrastId, value); }
        }

        // Colour Unsaturation (A = Factor), default = (1,1,1,0)
        public Color TintColor
        {
            get { return GetColor(Properties.Instance.TintColorId); }
            set { SetColor(Properties.Instance.TintColorId, value); }
        }

        // Specular Color, default = (0.2,0.2,0.2,0.2)
        public Color SpecularColor
        {
            get { return GetColor(Properties.Instance.SpecularColorId); }
            set { SetColor(Properties.Instance.SpecularColorId, value); }
        }

        // Brightness, default = 2
        public Single AlbedoBrightness
        {
            get { return GetFloat(Properties.Instance.AlbedoBrightnessId); }
            set { SetFloat(Properties.Instance.AlbedoBrightnessId, value); }
        }

        // Steep Blend, default = 1
        public Single SteepPower
        {
            get { return GetFloat(Properties.Instance.SteepPowerId); }
            set { SetFloat(Properties.Instance.SteepPowerId, value); }
        }

        // Steep Fade Start, default = 20000
        public Single SteepTexStart
        {
            get { return GetFloat(Properties.Instance.SteepTexStartId); }
            set { SetFloat(Properties.Instance.SteepTexStartId, value); }
        }

        // Steep Fade End, default = 30000
        public Single SteepTexEnd
        {
            get { return GetFloat(Properties.Instance.SteepTexEndId); }
            set { SetFloat(Properties.Instance.SteepTexEndId, value); }
        }

        // Steep Texture, default = "white" { }
        public Texture2D SteepTex
        {
            get { return GetTexture(Properties.Instance.SteepTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.SteepTexId, value); }
        }

        public Vector2 SteepTexScale
        {
            get { return GetTextureScale(Properties.Instance.SteepTexId); }
            set { SetTextureScale(Properties.Instance.SteepTexId, value); }
        }

        public Vector2 SteepTexOffset
        {
            get { return GetTextureOffset(Properties.Instance.SteepTexId); }
            set { SetTextureOffset(Properties.Instance.SteepTexId, value); }
        }

        // Steep Bump Map, default = "bump" { }
        public Texture2D SteepBumpMap
        {
            get { return GetTexture(Properties.Instance.SteepBumpMapId) as Texture2D; }
            set { SetTexture(Properties.Instance.SteepBumpMapId, value); }
        }

        public Vector2 SteepBumpMapScale
        {
            get { return GetTextureScale(Properties.Instance.SteepBumpMapId); }
            set { SetTextureScale(Properties.Instance.SteepBumpMapId, value); }
        }

        public Vector2 SteepBumpMapOffset
        {
            get { return GetTextureOffset(Properties.Instance.SteepBumpMapId); }
            set { SetTextureOffset(Properties.Instance.SteepBumpMapId, value); }
        }

        // Steep Near Tiling, default = 1
        public Single SteepNearTiling
        {
            get { return GetFloat(Properties.Instance.SteepNearTilingId); }
            set { SetFloat(Properties.Instance.SteepNearTilingId, value); }
        }

        // Steep Far Tiling, default = 1
        public Single SteepTiling
        {
            get { return GetFloat(Properties.Instance.SteepTilingId); }
            set { SetFloat(Properties.Instance.SteepTilingId, value); }
        }

        // Low Texture, default = "white" { }
        public Texture2D LowTex
        {
            get { return GetTexture(Properties.Instance.LowTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.LowTexId, value); }
        }

        public Vector2 LowTexScale
        {
            get { return GetTextureScale(Properties.Instance.LowTexId); }
            set { SetTextureScale(Properties.Instance.LowTexId, value); }
        }

        public Vector2 LowTexOffset
        {
            get { return GetTextureOffset(Properties.Instance.LowTexId); }
            set { SetTextureOffset(Properties.Instance.LowTexId, value); }
        }

        // Low Tiling, default = 100000
        public Single LowTiling
        {
            get { return GetFloat(Properties.Instance.LowTilingId); }
            set { SetFloat(Properties.Instance.LowTilingId, value); }
        }

        // Mid Texture, default = "white" { }
        public Texture2D MidTex
        {
            get { return GetTexture(Properties.Instance.MidTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.MidTexId, value); }
        }

        public Vector2 MidTexScale
        {
            get { return GetTextureScale(Properties.Instance.MidTexId); }
            set { SetTextureScale(Properties.Instance.MidTexId, value); }
        }

        public Vector2 MidTexOffset
        {
            get { return GetTextureOffset(Properties.Instance.MidTexId); }
            set { SetTextureOffset(Properties.Instance.MidTexId, value); }
        }

        // Mid Tiling, default = 100000
        public Single MidTiling
        {
            get { return GetFloat(Properties.Instance.MidTilingId); }
            set { SetFloat(Properties.Instance.MidTilingId, value); }
        }

        // Mid Bump Map, default = "bump" { }
        public Texture2D MidBumpMap
        {
            get { return GetTexture(Properties.Instance.MidBumpMapId) as Texture2D; }
            set { SetTexture(Properties.Instance.MidBumpMapId, value); }
        }

        public Vector2 MidBumpMapScale
        {
            get { return GetTextureScale(Properties.Instance.MidBumpMapId); }
            set { SetTextureScale(Properties.Instance.MidBumpMapId, value); }
        }

        public Vector2 MidBumpMapOffset
        {
            get { return GetTextureOffset(Properties.Instance.MidBumpMapId); }
            set { SetTextureOffset(Properties.Instance.MidBumpMapId, value); }
        }

        // Mid Bump Tiling, default = 100000
        public Single MidBumpTiling
        {
            get { return GetFloat(Properties.Instance.MidBumpTilingId); }
            set { SetFloat(Properties.Instance.MidBumpTilingId, value); }
        }

        // High Texture, default = "white" { }
        public Texture2D HighTex
        {
            get { return GetTexture(Properties.Instance.HighTexId) as Texture2D; }
            set { SetTexture(Properties.Instance.HighTexId, value); }
        }

        public Vector2 HighTexScale
        {
            get { return GetTextureScale(Properties.Instance.HighTexId); }
            set { SetTextureScale(Properties.Instance.HighTexId, value); }
        }

        public Vector2 HighTexOffset
        {
            get { return GetTextureOffset(Properties.Instance.HighTexId); }
            set { SetTextureOffset(Properties.Instance.HighTexId, value); }
        }

        // High Tiling, default = 100000
        public Single HighTiling
        {
            get { return GetFloat(Properties.Instance.HighTilingId); }
            set { SetFloat(Properties.Instance.HighTilingId, value); }
        }

        // Low Transition Start, default = 0
        public Single LowStart
        {
            get { return GetFloat(Properties.Instance.LowStartId); }
            set { SetFloat(Properties.Instance.LowStartId, value); }
        }

        // Low Transition End, default = 0.3
        public Single LowEnd
        {
            get { return GetFloat(Properties.Instance.LowEndId); }
            set { SetFloat(Properties.Instance.LowEndId, value); }
        }

        // High Transition Start, default = 0.8
        public Single HighStart
        {
            get { return GetFloat(Properties.Instance.HighStartId); }
            set { SetFloat(Properties.Instance.HighStartId, value); }
        }

        // High Transition End, default = 1
        public Single HighEnd
        {
            get { return GetFloat(Properties.Instance.HighEndId); }
            set { SetFloat(Properties.Instance.HighEndId, value); }
        }

        // AP Global Density, default = 1
        public Single GlobalDensity
        {
            get { return GetFloat(Properties.Instance.GlobalDensityId); }
            set { SetFloat(Properties.Instance.GlobalDensityId, value); }
        }

        // FogColorRamp, default = "white" { }
        public Texture2D FogColorRamp
        {
            get { return GetTexture(Properties.Instance.FogColorRampId) as Texture2D; }
            set { SetTexture(Properties.Instance.FogColorRampId, value); }
        }

        public Vector2 FogColorRampScale
        {
            get { return GetTextureScale(Properties.Instance.FogColorRampId); }
            set { SetTextureScale(Properties.Instance.FogColorRampId, value); }
        }

        public Vector2 FogColorRampOffset
        {
            get { return GetTextureOffset(Properties.Instance.FogColorRampId); }
            set { SetTextureOffset(Properties.Instance.FogColorRampId, value); }
        }

        // PlanetOpacity, default = 1
        public Single PlanetOpacity
        {
            get { return GetFloat(Properties.Instance.PlanetOpacityId); }
            set { SetFloat(Properties.Instance.PlanetOpacityId, value); }
        }

        // Ocean Fog Dist, default = 1000
        public Single OceanFogDistance
        {
            get { return GetFloat(Properties.Instance.OceanFogDistanceId); }
            set { SetFloat(Properties.Instance.OceanFogDistanceId, value); }
        }

        public PQSTriplanarZoomRotation() : base(Properties.Shader)
        {
        }

        [Obsolete("Creating materials from shader source String is no longer supported. Use Shader assets instead.")]
        public PQSTriplanarZoomRotation(String contents) : base(contents)
        {
            shader = Properties.Shader;
        }

        public PQSTriplanarZoomRotation(Material material) : base(material)
        {
            // Throw exception if this material was not the proper material
            if (material.shader.name != Properties.Shader.name)
                throw new InvalidOperationException(
                    "Type Mismatch: Terrain/PQS/PQS Triplanar Zoom Rotation shader required");
        }

    }
}
