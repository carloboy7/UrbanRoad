﻿using UnityEngine;
using System.Collections;

public class Level {
	private int levelId;
	private int blockWidth;
	private int blockHeight;
	private Block[] blocks;
	private Vector2 startPos;
	private Vector2 endPos;

	public Level setWidth(int width){
		blockWidth = width;
		return this;
	}

	public Level setHeight(int height){
		blockHeight = height;
		return this;
	}

	public Level setBlocks(Block[] blocks){
		this.blocks = blocks;
		return this;
	}
	public Level setStart(Vector2 start){
		startPos = start;
		return this;
	}
	public Level setEnd(Vector2 end){
		endPos = end;
		return this;
	}
	public Level(int levelId){
		this.levelId = levelId;
	}
	public int getId(){
		return levelId;
	}
	public void clear(){
	}

	public Block[] getBlocks(){
		return blocks;
	}

	public Vector2 getStart(){
		return startPos;
	}
		
	public Vector2 getFinish(){
		return endPos;
	}

	public void saveToDevice(){
	}

	public bool isValidPath(){
		return true;
	}
		
	public Block getPos(int x, int y){
		return null;
	}

	public bool setBlock(int x, int y, Block block){
		return true;
	}

	public bool canSet(int x, int y, Block block){
		return true;
	}

	public RoadPiece[] getRoad(){
		return new RoadPiece[2];
	}

	public int getHeight(){
		return blockHeight;
	}
	public int getWidth(){
		return blockWidth;
	}

}
