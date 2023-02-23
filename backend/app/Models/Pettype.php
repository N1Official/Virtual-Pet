<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;

class Pettype extends Model
{
    protected $fillable = [
        "pettype"
    ];
    use HasFactory;
    protected $table = 'pettype';
    public $timestamps = false;
    protected $primaryKey = 'pettype';
    protected $keyType = 'string';
}
