<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Mood extends Model
{
    protected $fillable = [
        "mood"
    ];
    use HasFactory;
    protected $table = 'moods';
    public $timestamps = false;
    protected $primaryKey = 'mood';
    protected $keyType = 'string';
}
