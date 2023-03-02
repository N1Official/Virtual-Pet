<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Pet extends Model
{
    protected $fillable = [
        "name","type","hunger","thirst","mood","speed","health","skill","age","age_group"
    ];
    use HasFactory;
    protected $table = 'pets';
    protected $primaryKey = 'id';
    public $timestamps = false;
    public $incrementing = false; 
}
