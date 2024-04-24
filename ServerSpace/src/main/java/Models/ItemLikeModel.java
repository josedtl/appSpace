package Models;

import com.fasterxml.jackson.annotation.JsonProperty;

public class ItemLikeModel {
    public ItemLikeModel() {
        this.srtValor1 = "";
        this.srtValor2 = "";
        this.intValor1 = 0;
        this.intValor2 = 0;
    }

    @JsonProperty("srtValor1")
    private String srtValor1 = "";

    public String getSrtValor1() {
        return srtValor1;
    }

    public void setSrtValor1(String srtValor1) {
        this.srtValor1 = srtValor1;
    }

    @JsonProperty("srtValor2")
    private String srtValor2 = "";

    public String getSrtValor2() {
        return srtValor2;
    }

    public void setSrtValor2(String srtValor2) {
        this.srtValor2= srtValor2;
    }

    @JsonProperty("intValor1")
    private int intValor1 = 0;

    public int getIntValor1() {
        return intValor1;
    }

    public void setIntValor1(int intValor1) {
        this.intValor1 = intValor1;
    }
    @JsonProperty("intValor2")
    private int intValor2 = 0;

    public int getIntValor2() {
        return intValor2;
    }

    public void setIntValor2(int intValor2) {
        this.intValor2 = intValor2;
    }
}
