// RadialBlur.frag
void main() {
    vec2 startCoord = TexCoord;
    vec2 dif = startCoord - 0.5;
    dif *= 0.001;
    vec4 finalColor;
    for (int i = 0; i < blurSize; i++) {
        vec2 newCoord = (startCoord + (dif * i));
        finalColor += texture(InputTexture, newCoord) * (1.0 / float(blurSize));
    }
    FragColor = finalColor;
}